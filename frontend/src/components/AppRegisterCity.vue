<template>
    <v-container >
        <v-card class="mx-auto px-6 py-8" max-width="350">
            <v-form>
                <v-text-field
                    v-model="state.name"
                    :counter="10"
                    :error-messages="v$.name.$errors.map(e => String(e.$message))"
                    :label= "t('name')"
                    required
                    @blur="v$.name.$touch"
                    @input="v$.name.$touch"
                    class="mb-2"
                ></v-text-field>

                <v-text-field
                    v-model="state.country"
                    :error-messages="v$.country.$errors.map(e => String(e.$message))"
                    :label="t('country')"
                    required
                    @blur="v$.country.$touch"
                    @input="v$.country.$touch"
                    class="mb-2"
                ></v-text-field>
            
                <v-text-field
                    v-model="state.population"
                    :error-messages="v$.population.$errors.map(e => String(e.$message))"
                    :label="t('population')"
                    required
                    @blur="v$.population.$touch"
                    @input="v$.population.$touch"
                    class="mb-2"
                ></v-text-field>
            
                <v-btn
                    class="me-4"
                    @click="submit"
                >
                    {{ t('confirm') }}
                </v-btn>
                <v-btn @click="clear">
                     {{ t('clean') }}
                </v-btn>
            </v-form>
        </v-card>
    </v-container>
  </template>

<script setup lang="ts">
    import { onMounted, reactive } from 'vue'
    import { useVuelidate } from '@vuelidate/core'
    import { required } from '@vuelidate/validators'
    import { initialCityFormState } from '@/types/state.ts';
    import type { StateCity } from '@/types/state.ts';
    import { toast } from "vue3-toastify";
    import router from '@/router';
    import type { NewCity, CityResult } from '@/types/city';
    import { useI18n } from 'vue-i18n'
    import { useCitiesStore } from '@/stores/cityStore'


    const { t } = useI18n()
    const state = reactive<StateCity>({
        ...initialCityFormState,
    })


    const rules = {
        name: { required },
        country: { required },
        population: { required },
    }

    const v$ = useVuelidate(rules, state)
    const store = useCitiesStore()
    

    async function submit () {
        v$.value.$touch()

        if (v$.value.$invalid) {
            console.log('Formulario no válido');
            return;
        }

        const newCity = buildNewCity()
        console.log(newCity);
        try {

            if (isDuplicateCity(newCity.nombre, newCity.pais)) {
                toast(t('duplicated'), { 
                    type: "error", 
                    onClose: () => {
                        state.name = ''; 
                    }
                }
            );
                throw new Error("Esta ciudad ya está registrada");
            }

            const result: CityResult = await store.addCity(newCity);

            toast(t(result.message), {
                type: result.success ? 'success' : 'error', 
                onClose: () => {
                    clear()
                    if (result.success) { router.push('/');}
                },
            });
            
        } catch (error) {
            console.log('Error:', error);
        }
    }

    function clear () {
        v$.value.$reset()
        Object.assign(state, initialCityFormState);
    }


    function buildNewCity(): NewCity {
        return {
            nombre: state.name,
            pais: state.country,
            poblacion: state.population,
            softDelete: state.softDelete
        }   
    }

    
    function isDuplicateCity(nombre: string, pais: string): boolean {
        return store.cities.some(city => city.nombre === nombre && city.pais === pais);
    }


    onMounted(async () => {
        await store.fetchAll()
        console.log(store.cities);
        
    })
</script>

<style scoped>


</style>