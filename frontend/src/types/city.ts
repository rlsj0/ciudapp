export interface NewCity {
    nombre: string, 
    pais: string,
    poblacion: number, 
    softDelete: boolean
}


export interface City extends NewCity {
    id: number, 
    fechaRegistro: Date
}



export interface CityResult {
    success: boolean;
    message: string;
}