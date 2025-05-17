import type { City, NewCity } from "@/types/city";
import { defineStore } from "pinia";
import { reactive, ref } from "vue";

export const useCitiesStore = defineStore('cities', () => {

  const cities = reactive(new Array<City>())
  const isLoaded = ref(false)
  const url = `${window.location.protocol}//${window.location.hostname}`


  async function fetchAll() {

    if (cities.length === 0) {
      try {
        const response = await fetch(`${url}:8080/Ciudad`);
        const data = await response.json();


        //Cambie el mapeo de ingles a español
        const citiesInfo = data.map((c: any) => ({
          id: c.id,
          nombre: c.nombre,
          pais: c.pais,
          poblacion: c.poblacion,
          softDelete: c.softDelete,
          fechaRegistro: c.fechaRegistro
        }))

        cities.push(...citiesInfo);
        console.log('Ciudades registradas correctamente');

      } catch (error) {
        console.log('Error en cargar las ciudades:', error);
      }
    }

  }


  async function addCity(city: NewCity) {

    try {
      const response = await fetch(`${url}:8080/Ciudad`, {
        method: "POST",
        headers: { "Content-type": "application/json;charset=UTF-8" },
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
      return { success: false, message: 'koConection' };
    }

  }



  async function deleteCity(id: number) {
    try {
      const response = await fetch(`${url}:8080/Ciudad/${id}`, {
        method: 'DELETE',
        headers: { "Content-type": "application/json;charset=UTF-8" },
      })

      if (response.ok) {
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
      return { success: false, message: 'koConection' };
    }
  }



  return {
    cities, fetchAll, addCity, deleteCity, isLoaded
  }

})
