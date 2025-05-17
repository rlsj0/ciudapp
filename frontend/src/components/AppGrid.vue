<template>
    <v-container class="mt-10">
        <v-row align="center" no-gutters>
            <v-col v-for="city in store.cities" :key="city.id">
                <AppCard :city="city" />
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup lang="ts">
import AppCard from '@/components/AppCard.vue'

import { useCitiesStore } from '@/stores/cityStore.ts'

const store = useCitiesStore()

store.fetchAll()

</script>

<style lang="scss" scoped>

</style>