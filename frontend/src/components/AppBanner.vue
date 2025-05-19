<template>
    <div class="banner">
      <v-parallax
        :src="bannerImage"
        cover
        class="banner__img"
      >
        <div class="banner__overlay d-flex flex-column justify-center align-center text-center px-4">
          <h1 class="text-h3 text-md-h2 text-lg-h1 font-weight-bold banner__title">CiudApp</h1>
          <v-btn @click="emit('scrollToCities')" class="elevation-4 rounded-xl mt-6 banner__button">
            {{ t("viewCities") }}
          </v-btn>
        </div>
      </v-parallax>
    </div>
  </template>
  
  <script setup lang="ts">
    import { useI18n } from 'vue-i18n'
 
    const { t } = useI18n() 
    const bannerImage = new URL('@/assets/fondo.png', import.meta.url).href

    const emit = defineEmits<{
      (e: 'scrollToCities'): void;
    }>();

    console.log('Banner image URL:', bannerImage);

  </script>
  
  <style lang="scss" scoped>
  .banner {
    width: 100%;
    overflow: hidden;
    margin: 0;
    padding: 0;

    &__overlay {
       position: relative;
      top: 0;
      left: 0;
      height: 100%;
      width: 100%;
      padding: 0 10px;
    }

    &__title {
        color: $color-bg;
    }

    &__img {
      height: 100vh;
    }

    &__button {
        @include button-styles;
      }
  }
  


  @media (min-width: 1024px) {
    .banner {
      height: 100vh;
      width: 100vw; 
      margin-left: calc(-50vw + 50%); 

        &__overlay {
          padding: 0 50px;
        } 
    }
  }

  </style>
  