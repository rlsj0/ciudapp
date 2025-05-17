<script setup lang="ts">
import { useRouter } from "vue-router"
import type { City } from "@/types/city";
import { useI18n } from 'vue-i18n'

const { t } = useI18n() 

const router = useRouter()

const props = defineProps<{
    city: City
}>()

function goReviews(id: number) {
    router.push(`/cities/${id}`)
}


</script>

<template>
    <v-card class="mx-auto mt-8" v-on:click="goReviews(props.city.id)">
        <v-card-title>{{ props.city.nombre }}</v-card-title>
        <v-card-subtitle class="pt-4">{{ props.city.pais }}</v-card-subtitle>

        <div class="card-info pa-4">
            <span class="text-left">{{ t("population") }} {{ props.city.poblacion }}</span>
            <!--<span class="text-right">{{ props.city.fechaRegistro }}</span>-->
        </div>
    </v-card>
</template>

<style lang="scss" scoped>
.v-card {
    background-color: $color-primary;
    width: 300px;
    border-radius: 20px;

    &:hover {
        background-color: #8b85b9;
        transition: background-color 0.2s;
    }

    &-title {
        font-size: $font-size-h1;
        text-align: center;
        color: $text-secondary;
    }

    &-subtitle {
        font-size: $font-size-h2;
        text-align: center;
        color: $text-secondary;
    }
}

.card-info {
    display: flex;
    justify-content: space-between;
    align-items: center;
    text-align: center;
    align-items: end;
    font-size: $font-size-body;
}

.text-left {
    text-align: left;
    color: $text-secondary;
}

.text-right {
    text-align: right;
    color: $text-secondary;
}
</style>
