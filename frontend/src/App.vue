<script setup lang="ts">
import { RouterView } from 'vue-router'
import Header from './components/AppHeader.vue'

</script>

<template>
  <v-app class="d-flex flex-column min-h-screen">
    <Header />
    <v-main class="flex-grow-1 d-flex flex-column fill-height">
      <RouterView />
    </v-main>
  </v-app>
</template>

<style lang="scss" scoped>

</style>
