import type { Resena, NewResena } from "@/types/resena";
import { defineStore } from "pinia";
import { reactive, ref } from "vue";

export const useResenasStore = defineStore('resenas', () => {

    const resenas = reactive(new Array<Resena>())
    const isLoaded = ref(false)


    async function fetchAll() {
    
        if (resenas.length === 0) {
            try {
                const response = await fetch('http://localhost:3000/resenas');
                const data =  await response.json();

                const resenasInfo = data.map((c:Resena) => ({
                    id: c.id,
                    cityId: c.cityId,
                    title: c.title,
                    description: c.description,
                    rating: c.rating,
                    dateRegister: c.dateRegister,
                    recomendation: c.recomendation
                }))

                resenas.push(... resenasInfo);
                console.log('Reseñas registradas correctamente');

            } catch (error) {
                console.log('Error en cargar las reseñas:', error);
            }
        } 

    }


    async function addResena(resena:NewResena) {

        try {
            const response = await fetch('http://localhost:3000/resenas', {
                method: "POST",
                headers: {"Content-type": "application/json;charset=UTF-8"},
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
            return  { success: false, message: 'koConection' };
        }  

    }

    

    async function deleteResena (id:number) {
        try {
            const response = await fetch(`http://localhost:3000/resenas/${id}`, {
                method: 'DELETE',
                headers: {"Content-type": "application/json;charset=UTF-8"},
            })

            if(response.ok) {
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
            return  { success: false, message: 'koConection' };
        }
    }



    return { resenas, fetchAll, addResena, deleteResena, isLoaded
    }

})