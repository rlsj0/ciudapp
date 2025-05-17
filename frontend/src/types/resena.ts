import { extractColor } from "vuetify/components/VColorPicker/util"

export interface NewResena {
    ciudadId: number, 
    titulo: string, 
    descripcion: string,
    calificacion: number, 
    recomendacion: boolean
}


export interface Resena extends NewResena {
    id: number,
    fecha: Date, 
}


export interface ResenaResult {
    success: boolean;
    message: string;
}