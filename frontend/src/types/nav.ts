import type { RouteLocationRaw } from "vue-router";

export interface NavItems {
    title: string,
    to: string | RouteLocationRaw,
    icon: string 
}