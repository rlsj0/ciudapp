<template>
    <v-card class="card ma-4 pa-4" max-width="500">
        <v-card-title class="text-h6 card__title">
            {{ props.review.titulo }} {{ '★'.repeat(props.review.calificacion) }}
        </v-card-title>

        <v-card-text class="text-body-1">
            {{ props.review.descripcion }}
        </v-card-text>

        <v-card-text class="text-body-1">
            ¿Recomendaria esta ciudad a sus amigos o familia?
            <v-icon icon='mdi-thumb-up' v-if="props.review.recomendacion" />
            <v-icon icon='mdi-thumb-down' v-else />
        </v-card-text>

        <v-card-text class="text-caption text-disabled">
        <!-- Fecha: {{ formatDate(props.review.dateRegister.toDateString()) }}-->
        </v-card-text>

        <v-btn icon="mdi-close-thick" size="x-small" color="red" v-on:click="deleteReview(props.review.id)"> </v-btn>
    </v-card>
</template>

<script setup lang="ts">

import type { Resena } from '@/types/resena.ts'
import { useResenasStore } from '@/stores/resenaStore.ts'


const store = useResenasStore()
console.log("resenas" + store.resenas);

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

console.log(store.resenas);

</script>


<style scoped lang="scss">
    .v-card {
        width: 450px;
        height: 300px;
        display: flex;
        flex-direction: column;
    }
</style>
