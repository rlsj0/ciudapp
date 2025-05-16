import Vue3Toastify, { type ToastContainerOptions } from 'vue3-toastify';
import "vue3-toastify/dist/index.css";


export const toastifyOptions: ToastContainerOptions = {
    autoClose: 2000,
    position: "top-right",
    pauseOnHover: true,
    closeOnClick: true,
    theme: "light"
  };