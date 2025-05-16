<template>
    <v-card class="ma-4 pa-4" max-width="500">
        <v-card-title class="text-h6">
            {{ props.review.title }} {{ '★'.repeat(props.review.rating) }}
        </v-card-title>

        <v-card-text class="text-body-1">
            {{ props.review.description }}
        </v-card-text>

        <v-card-text class="text-body-1">
            ¿Recomendaria esta ciudad a sus amigos o familia?
            <v-icon icon='mdi-thumb-up' v-if="props.review.recomendation" />
            <v-icon icon='mdi-thumb-down' v-else />
        </v-card-text>

        <v-card-text class="text-caption text-disabled">
            Fecha: {{ formatDate(props.review.dateRegister) }}
        </v-card-text>

        <v-btn icon="mdi-close-thick" size="x-small" color="red" v-on:click="deleteReview(props.review.id)"> </v-btn>
    </v-card>
</template>

<script setup lang="ts">

import type { Resena } from '@/types/resena.ts'
import { useResenasStore } from '@/stores/resenaStore.ts'

const store = useResenasStore()

const props = defineProps<{
    review: Resena
}>()

function formatDate(date: string) {
    return date.split('T')[0]
}

function deleteReview(id: number) {
    const confirmed = window.confirm("¿Estás seguro de que deseas eliminar esta reseña?");
    if (confirmed) {
        store.deleteResena(id);
    }
}

</script>


<style scoped lang="scss">
.v-card {
    height: auto;
    display: flex;
    flex-direction: column;
}
</style>
