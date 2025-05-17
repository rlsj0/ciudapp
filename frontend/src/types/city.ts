export interface NewCity {
    name: string, 
    country: string,
    population: number, 
    softDelete: boolean
}


export interface City extends NewCity {
    id: number, 
    dateRegister: Date
}



export interface CityResult {
    success: boolean;
    message: string;
}