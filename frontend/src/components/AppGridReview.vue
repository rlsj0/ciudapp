<template>
    <v-container justify="center">
            <v-row justify="center" align="start" no-gutters>
                <v-col  class="d-flex flex-column justify-center align-center"v-for="resena in store.resenas" :key="resena.id">
                    <AppCardReview :review="resena" />
                </v-col>
            </v-row>
    </v-container>
</template>

<script setup lang="ts">

import AppCardReview from '@/components/AppCardReview.vue'
import { useResenasStore } from '@/stores/resenaStore.ts'

const store = useResenasStore()

</script>

<style lang="scss" scoped></style>