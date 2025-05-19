<script setup lang="ts">
import AppGridReview from "../components/AppGridReview.vue"


import { useResenasStore } from '@/stores/resenaStore.ts'
import { useCitiesStore } from '@/stores/cityStore.ts'
import { useRoute } from 'vue-router'
import { useI18n } from 'vue-i18n'
import { computed } from "vue"

const { t } = useI18n()

const route = useRoute()
const storeResena = useResenasStore()
const storeCity = useCitiesStore()

const id = route.params.id

storeResena.fetchCity(parseInt(id as string))
storeResena.fetchAll(parseInt(id as string))


const cityId = parseInt(id as string)

const city = computed(() => {
  return storeCity.cities.find(c => c.id === cityId)
})

console.log('ReviewView.vue montado')
</script>

<template>
    <v-container class="container">
        <div class="d-flex flex-column justify-center align-center">
        <h1 class="text-h4 text-md-h3 mb-6 mb-md-10 text-center mt-3 mt-md-10">{{ city?.nombre }}</h1>
        <v-btn class="elevation-4 rounded-xl mt-6 container__button"
        :to="{ name: 'Registro', params: { tipo: 'resena' } }"
        >{{ t("addResena") }}</v-btn>
     </div>
     <AppGridReview />
     
    </v-container>
</template>


<style lang="scss" scoped>
    h1 {
        color: $color-primary;
        font-weight: $font-title-weight-bold;
    }

    .container {

        &__button {
            @include button-styles;
        }
    }
</style>
