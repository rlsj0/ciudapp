<template>
    <v-container>
        <v-row align="center" style="height: 150px" no-gutters>
            <v-col v-for="n in 3" :key="n">
                <v-sheet class="pa-2 ma-2">
                    <AppCard />
                </v-sheet>
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup lang="ts">
import AppCard from '@/components/AppCard.vue'
</script>

<style lang="scss" scoped>
 
.v-sheet {
    background-color: #B1AED1;
    border-radius: 20px;
}

</style>