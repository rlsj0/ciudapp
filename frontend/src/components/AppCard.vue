<template>
    <v-card class="mx-auto" max-width="400">
        <v-card-title>Ciudad</v-card-title>
        <v-card-subtitle class="pt-4">País</v-card-subtitle>

        <div class="card-info pa-4">
            <span class="text-left">Población</span>
            <span class="text-right">Fecha</span>
        </div>
    </v-card>
</template>


<script setup lang="ts">
</script>

<style lang="scss" scoped>
.v-card {
    background-color: $color-primary;
    height: 100%;
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
