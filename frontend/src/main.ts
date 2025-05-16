//Vuetify
import vuetify from './plugins/vuetify'

import { createApp } from 'vue'
import { createPinia } from 'pinia'
import '@/assets/styles/style.scss';

import App from './App.vue'
import router from './router'

//Toastify
import Vue3Toastify from 'vue3-toastify';
import { toastifyOptions } from './plugins/toastify';
import "vue3-toastify/dist/index.css";

const app = createApp(App)

app.use(createPinia())
app.use(router)
app.use(vuetify)
app.use(Vue3Toastify, toastifyOptions);

app.mount('#app')
