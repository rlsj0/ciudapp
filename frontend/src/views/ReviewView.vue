<script setup lang="ts">
import AppGridReview from "../components/AppGridReview.vue"


import { useResenasStore } from '@/stores/resenaStore.ts'
import { useRoute } from 'vue-router'

const route = useRoute()
const store = useResenasStore()

const id = route.params.id

store.fetchCity(parseInt(id as string))
store.fetchAll(parseInt(id as string))
</script>

<template>
    <v-main>
        <div>
            <!-- <div v-if="store.city && store.city.name">
                <h1>{{ store.city.name }}</h1>

            </div> -->
            <AppGridReview />
        </div>

    </v-main>
</template>


<style lang="scss" scoped>
.h1 {
    color: black;
}
</style>
