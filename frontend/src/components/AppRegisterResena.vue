<template>
    <v-container >
        <v-card class="mx-auto px-6 py-8" max-width="350">
            <v-form>
                <v-text-field
                    v-model="state.title"
                    :counter="10"
                    :error-messages="v$.title.$errors.map(e => String(e.$message))"
                    :label= "t('title')"
                    required
                    @blur="v$.title.$touch"
                    @input="v$.title.$touch"
                    class="mb-2"
                ></v-text-field>

                <v-text-field
                    v-model="state.description"
                    :error-messages="v$.description.$errors.map(e => String(e.$message))"
                    :label="t('description')"
                    required
                    @blur="v$.description.$touch"
                    @input="v$.description.$touch"
                    class="mb-2"
                ></v-text-field>
            
                <v-text-field
                    type="number"
                    v-model="state.rating"
                    :error-messages="v$.rating.$errors.map(e => String(e.$message))"
                    :label="t('rating')"
                    required
                    @blur="v$.rating.$touch"
                    @input="v$.rating.$touch"
                    class="mb-2"
                    :max="5"
                    :min="0"
                ></v-text-field>

                <v-radio-group
                    v-model="state.recomendation"
                    :label="t('isRecomended')"
                    class="mb-2"
                    >
                    <v-radio :label="t('si')" :value="true"></v-radio>
                    <v-radio :label="t('no')" :value="false"></v-radio>
                </v-radio-group>


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
    import { reactive } from 'vue'
    import { useVuelidate } from '@vuelidate/core'
    import { required } from '@vuelidate/validators'
    import { initialResenaFormState } from '@/types/state.ts';
    import type { StateResena } from '@/types/state.ts';
    import { toast } from "vue3-toastify";
    import router from '@/router';
    import type { NewResena, ResenaResult } from '@/types/resena';
    import { useI18n } from 'vue-i18n'
    import { useResenasStore } from '@/stores/resenaStore'


    const { t } = useI18n()
    const state = reactive<StateResena>({
        ...initialResenaFormState,
    })


    const rules = {
        title: { required },
        description: { required },
        rating: { required },
        recomendation: { required }
    }

    const v$ = useVuelidate(rules, state)
    const store = useResenasStore()



    async function submit () {
        v$.value.$touch()

        if (v$.value.$invalid) {
            console.log('Formulario no válido');
            return;
        }

        const newResena = buildNewResena();


            const result: ResenaResult = await store.addResena(newResena);

            toast(t(result.message), {
                type: result.success ? 'success' : 'error', 
                onClose: () => {
                    clear()
                    if (result.success) { router.push(`/cities/${newResena.ciudadId}`);}
                },
            });
            

        }


    function clear () {
        v$.value.$reset()
        Object.assign(state, initialResenaFormState);
    }
    

    function buildNewResena(): NewResena {
        return {
            ciudadId: 1,
            titulo: state.title,
            descripcion: state.description,
            calificacion: state.rating,
            recomendacion: state.recomendation
        }   
    }


</script>

<style scoped>


</style>