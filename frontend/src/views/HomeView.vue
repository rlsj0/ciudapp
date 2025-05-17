<script setup lang="ts">
  import { nextTick, useTemplateRef } from "vue";
  import AppGrid from "../components/AppGrid.vue"
  import Banner from "../components/AppBanner.vue"

    const cities = useTemplateRef('my-cities');


  function scrollToCities() {
    nextTick(() => {
      cities.value?.scrollIntoView({ behavior: 'smooth', block: 'center' })
    });
  }
</script>

<template>
    <Banner 
      @scroll-to-cities="scrollToCities"
    />
    <section ref="my-cities" >
      <AppGrid />
    </section>
</template>

<style lang="scss" scoped></style>
