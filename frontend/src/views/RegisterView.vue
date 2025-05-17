<template>
    <v-container class="fill-height d-flex flex-column align-center">
        <h1 class="text-h4 text-md-h3 mb-6 mb-md-10 text-center mt-3 mt-md-10">REGISTRO</h1>
        <RegisterForm v-if="route.query.type === 'city'" />
        <RegisterResena v-else-if="route.query.type === 'resena'" />

        <v-btn @click="router.back()" class="elevation-4 rounded-xl mt-6 mx-auto" color="black">Atrás</v-btn>
    </v-container>
</template>


<script setup lang="ts">
    import RegisterForm from '../components/AppRegisterCity.vue'
    import RegisterResena from '../components/AppRegisterResena.vue'
    
    import { useRouter, useRoute} from 'vue-router'
    
    const router = useRouter();
    const route = useRoute()

    
</script>

<style scoped>

</style>