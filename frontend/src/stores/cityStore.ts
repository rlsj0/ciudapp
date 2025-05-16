import type { City, NewCity } from "@/types/city";
import { defineStore } from "pinia";
import { reactive, ref } from "vue";

export const useCitiesStore = defineStore('cities', () => {

    const cities = reactive(new Array<City>())
    const isLoaded = ref(false)


    async function fetchAll() {
    
        if (cities.length === 0) {
            try {
                const response = await fetch('http://localhost:3000/cities');
                const data =  await response.json();

                const citiesInfo = data.map((c:City) => ({
                    id: c.id,
                    name: c.name,
                    country: c.country,
                    population: c.population,
                    softDelete: c.softDelete,
                    dateRegister: c.dateRegister
                }))

                cities.push(... citiesInfo);
                console.log('Ciudades registradas correctamente');

            } catch (error) {
                console.log('Error en cargar las ciudades:', error);
            }
        } 

    }


    async function addCity(city:NewCity) {

        try {
            const response = await fetch('http://localhost:3000/cities', {
                method: "POST",
                headers: {"Content-type": "application/json;charset=UTF-8"},
                body: JSON.stringify(city)
            })
            const data = await response.json();

            if (response.ok) {
                const newCity = { ...data }
                cities.push(newCity)
                console.log('Ciudad registrada correctamente:', data);
                return { success: true, message: 'okCity' };
            } else {
                console.log('Error al registrar pista');
                return { success: false, message: 'koCity' };
            }
        } catch (error) {
            console.log('Error:', error);
            return  { success: false, message: 'koConection' };
        }  

    }

    

    async function deleteCity (id:number) {
        try {
            const response = await fetch(`http://localhost:3000/cities/${id}`, {
                method: 'DELETE',
                headers: {"Content-type": "application/json;charset=UTF-8"},
            })

            if(response.ok) {
                const index = cities.findIndex(r => r.id === id);
                if (index !== -1) {
                    cities.splice(index, 1);
                }
                console.log('Ciudad eliminada correctamente');
                return { success: true, message: 'okDeleteCity' };
            } else {
                console.log('Error al eliminar la ciudad');
                return { success: false, message: 'koDeleteCity' };
            }
            
        } catch (error) {
            console.log('Error: ', error);
            return  { success: false, message: 'koConection' };
        }
    }



    return { cities, fetchAll, addCity, deleteCity, isLoaded
    }

})