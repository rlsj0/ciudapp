import type { Resena, NewResena } from "@/types/resena";
import type { City, NewCity } from "@/types/city";
import { defineStore } from "pinia";
import { reactive, ref } from "vue";

export const useResenasStore = defineStore('resenas', () => {

  const resenas = reactive(new Array<Resena>())
  const city = reactive<City>({
    id: 0,
    name: '',
    country: '',
    population: 0,
    softDelete: false,
    dateRegister: new Date()
  })
  const isLoaded = ref(false)


  async function fetchAll(id: number) {

    try {
      const response = await fetch('http://localhost:8080/Ciudad/' + id + '/Resena');
      const data = await response.json();

      const resenasInfo = data.map((c: any) => ({
        id: c.id,
        cityId: c.ciudadId,
        title: c.titulo,
        description: c.descripcion,
        rating: c.calificacion,
        dateRegister: c.fecha,
        recomendation: c.recomendacion
      }))

      resenas.length = 0

      resenas.push(...resenasInfo);
      console.log('Reseñas registradas correctamente');

    } catch (error) {
      console.log('Error en cargar las reseñas:', error);
    }
  }

  async function addResena(resena: NewResena) {

    try {
      const response = await fetch('http://localhost:8080/Resena', {
        method: "POST",
        headers: { "Content-type": "application/json;charset=UTF-8" },
        body: JSON.stringify(resena)
      })
      const data = await response.json();

      if (response.ok) {
        const newResena = { ...data }
        resenas.push(newResena)
        console.log('Reseña registrada correctamente:', data);
        return { success: true, message: 'okResena' };
      } else {
        console.log('Error al registrar reseña');
        return { success: false, message: 'koResena' };
      }
    } catch (error) {
      console.log('Error:', error);
      return { success: false, message: 'koConection' };
    }

  }



  async function deleteResena(id: number) {
    try {
      const response = await fetch(`http://localhost:8080/Resena/${id}`, {
        method: 'DELETE',
        headers: { "Content-type": "application/json;charset=UTF-8" },
      })

      if (response.ok) {
        const index = resenas.findIndex(r => r.id === id);
        if (index !== -1) {
          resenas.splice(index, 1);
        }
        console.log('Reseña eliminada correctamente');
        return { success: true, message: 'okDeleteResena' };
      } else {
        console.log('Error al eliminar la reseña');
        return { success: false, message: 'koDeleteResena' };
      }

    } catch (error) {
      console.log('Error: ', error);
      return { success: false, message: 'koConection' };
    }
  }

  async function fetchCity(id: number) {

    try {
      const response = await fetch('http://localhost:8080/Ciudad/' + id);
      const data = await response.json();

      console.log(data)
      city.id = data.id;
      city.name = data.nombre;
      city.country = data.pais;
      city.population = data.poblacion;
      city.softDelete = data.softDelete;
      city.dateRegister = data.fechaRegistro;
      console.log('Ciudad obtenida correctamente');

    } catch (error) {
      console.log('Error en cargar la Ciudad:', error);
    }
  }
  return {
    resenas, fetchAll, addResena, deleteResena, isLoaded, fetchCity
  }

})
