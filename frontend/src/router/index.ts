import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Register from '../views/RegisterView.vue'
import RegisterView from '../views/RegisterView.vue'
import ReviewView from '@/views/ReviewView.vue'


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
      name: 'registro',
      component: () => import('@/views/RegisterView.vue')
    },
    {
      path: '/cities/:id',
      name: 'review',
      component: ReviewView,
    }
  ],
})





export default router
