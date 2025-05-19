<template>
    <v-container class="fill-height d-flex flex-column align-center container">
        <h1 class="text-h4 text-md-h3 mb-6 mb-md-10 text-center mt-3 mt-md-10"> {{ t("register") }}</h1>
        <RegisterForm v-if="route.params.tipo === 'city' "/>
        <RegisterResena v-else />

        <v-btn @click="router.back()" class="container__button elevation-4 rounded-xl mt-6 mx-auto">{{ t("back") }}</v-btn>
    </v-container>
</template>


<script setup lang="ts">
    import RegisterForm from '../components/AppRegisterCity.vue'
    import RegisterResena from '../components/AppRegisterResena.vue'
    import { useI18n } from 'vue-i18n'
    
    import { useRouter, useRoute} from 'vue-router'
    
    const router = useRouter();
    const route = useRoute();
    const { t } = useI18n();

    console.log('Tipo en params:', route.params.tipo)

    
</script>

<style lang="scss" scoped>

    h1.container {

        &__button {
            @include button-styles;
        }
    }

</style>