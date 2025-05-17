import { extractColor } from "vuetify/components/VColorPicker/util"

export interface NewResena {
    cityId: number, 
    title: string, 
    description: string,
    rating: number, 
    recomendation: boolean
}


export interface Resena extends NewResena {
    id: number,
    dateRegister: Date, 
}


export interface ResenaResult {
    success: boolean;
    message: string;
}