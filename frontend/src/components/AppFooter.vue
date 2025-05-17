<template>
    <v-footer class="text-center d-flex flex-column ga-2 py-2 py-md-4 shrink-0 flex-0-0-auto footer">
        
        <div class="d-flex ga-3 justify-center">
            <v-btn
            v-for="icon in icons"
            :key="icon"
            :icon="icon"
            density="comfortable"
            variant="text"
            ></v-btn>
        </div>
    
        <v-divider class="my-1 mx-auto" thickness="2" width="50"></v-divider>
    
        <div class="text-caption font-weight-regular opacity-60">
          {{ t("slogan") }}
        </div>
    
        <v-divider class="my-2" color="white"></v-divider>
    
        <div>
            {{ new Date().getFullYear() }} — <strong>CiudApp</strong>
        </div>
        
    </v-footer>
</template>

<script setup lang="ts">
import { useI18n } from 'vue-i18n';


  const { t } = useI18n()

  const icons = [
    'mdi-facebook',
    'mdi-twitter',
    'mdi-linkedin',
    'mdi-instagram',
  ]

</script>

<style lang="scss" scoped>

    .footer {
        background-color: $color-primary;
        color: $color-bg;
    }

</style>