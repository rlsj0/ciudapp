import type { Resena, NewResena } from "@/types/resena";
import type { City, NewCity } from "@/types/city";
import { defineStore } from "pinia";
import { reactive, ref } from "vue";

export const useResenasStore = defineStore('resenas', () => {

  const resenas = reactive(new Array<Resena>())
  const city = reactive<City>({
    id: 0,
    nombre: '',
    pais: '',
    poblacion: 0,
    softDelete: false,
    fechaRegistro: new Date()
  })
  const isLoaded = ref(false)
  const url = `${window.location.protocol}//${window.location.hostname}`

  async function fetchAll(id: number) {

    try {
      const response = await fetch(`${url}:8080/Ciudad/` + id + '/Resena');
      const data = await response.json();

      const resenasInfo = data.map((c: any) => ({
        id: c.id,
        ciudadId: c.ciudadId,
        titulo: c.titulo,
        descripcion: c.descripcion,
        calificacion: c.calificacion,
        fecha: c.fecha,
        recomendacion: c.recomendacion
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
      const response = await fetch(`${url}:8080/Resena`, {
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
      const response = await fetch(`${url}:8080/Resena/${id}`, {
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
      const response = await fetch(`${url}:8080/Ciudad/` + id);
      const data = await response.json();

      console.log(data)
      city.id = data.id;
      city.nombre = data.nombre;
      city.pais = data.pais;
      city.poblacion = data.poblacion;
      city.softDelete = data.softDelete;
      city.fechaRegistro = data.fechaRegistro;
      console.log('Ciudad obtenida correctamente');

    } catch (error) {
      console.log('Error en cargar la Ciudad:', error);
    }
  }
  return {
    resenas, city, fetchAll, addResena, deleteResena, isLoaded, fetchCity
  }

})
