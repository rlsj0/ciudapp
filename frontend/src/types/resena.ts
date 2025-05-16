import { extractColor } from "vuetify/components/VColorPicker/util"

export interface NewResena {
    cityId: string, 
    title: string, 
    description: string,
    rating: number, 
    dateRegister: Date, 
    recomendation: boolean
}


export interface Resena extends NewResena {
    id: number
}