    //Estado del formulario de registro
    export interface StateCity {
        name: string;
        country: string,
        population: number, 
        softDelete: boolean
    }

    export const initialCityFormState: StateCity = {
        name: '',
        country: '',
        population: 0,
        softDelete: false
    }


    export interface StateResena {
        title: string, 
        description: string,
        rating: number, 
        recomendation: boolean
    }

    export const initialResenaFormState: StateResena = {
        title:  '',
        description: '',
        rating: 0, 
        recomendation: false,
    }