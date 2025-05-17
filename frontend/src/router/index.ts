import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import ReviewView from '../views/ReviewView.vue'

import { useCitiesStore } from '@/stores/cityStore';
import { useResenasStore } from '@/stores/resenaStore'



const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/registro/:tipo',
      name: 'Registro',
      component: () => import('@/views/RegisterView.vue')
    },
    {
      path: '/cities/:id',
      name: 'review',
      component: ReviewView,
    }
  ],
})


router.beforeEach(async (to, from, next) => {
  const citiesStore = useCitiesStore()
  const resenaStore = useResenasStore()


  if (!citiesStore.isLoaded) {
    await citiesStore.fetchAll()
    console.log('Dato cargado del BeforeEach');
  }
  next()
})





export default router
