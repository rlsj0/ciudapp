import { createI18n } from 'vue-i18n';


const messages = {
    es: {
        hello: 'hola mundo',
        user: 'Usuario | Usuarios',
        subtitle: 'Explora opiniones auténticas y planifica tu próxima aventura fácilmente',
        name: 'Nombre',
        si: 'Sí',
        no: 'No',
        confirm: 'Confirmar',
        clean: 'Limpiar',
        actions: 'Acciones',
        date: 'Fecha',
        surname: 'Apellido',
        email: 'Correo',
        id: 'ID', 
        back: 'Atrás',
        slogan: 'Descubre. Comparte. Vive cada ciudad',
        closingSession: 'Cerrando sesión',
        profile: 'Perfil',
        profileUser: 'Perfil de usuario',
        login: "Iniciar sesión",
        closeSession: 'Cerrar Sessión',
        password: 'Contraseña',
        noAccount: '¿No tienes cuenta?',
        registerHere: 'Regístrate aquí',
        okLogin: 'Inicio de sesión correcto',
        koLogin: 'Usuario o contraseña incorrectos',
        errorLogin: 'Error al intentar iniciar sesión',
        duplicated: 'Esta ciudad ya está registrada',
        cancel: 'Cancelar',
        saveChanges: 'Guardar cambios',
        userData: 'Datos personales',
        okCity: 'Ciudad registrada',
        koCity: 'Error al registrar la ciudad',
        koConection: 'Error en la conexión con el servidor',
        okDeleteCity: 'Ciudad eliminada',
        koDeleteCity: 'Error al eliminar la ciudad',
        okResena: 'Reseña registrada',
        koResena: 'Error al registrar reseña',
        okDeleteResena: 'Reseña eliminada',
        koDeleteResena: 'Error al eliminar reseña',
        population: 'Población',
        country: 'País',
        title: 'Título',
        description: 'Descripción',
        rating: 'Puntuación',
        isRecomended: 'Recomendarías esta ciudad a familiares y amigos?',
        viewCities: 'Ciudades',
        addCity: 'Añadir ciudad',
        register: 'Registro',
        addResena: 'Añadir reseña'
    }
    ,
    en: {
        hello: 'hello world',
        user: 'User | Users',
        subtitle: 'Explore authentic reviews and plan your next adventure easily',
        name: 'Name',
        si: 'Yes',
        no: 'No',
        confirm: 'Confirm',
        clean: 'Clean',
        actions: 'Actions',
        date: 'Date',
        surname: 'Surname',
        email: 'Email',
        id: 'ID',
        back: 'Back',
        slogan: 'Discover. Share. Live every city',
        closingSession: 'Logging out',
        profile: 'Profile',
        profileUser: 'User profile',
        login: 'Log in',
        closeSession: 'Log out',
        password: 'Password',
        noAccount: "Don't have an account?",
        registerHere: 'Register here',
        okLogin: 'Login successful',
        koLogin: 'Incorrect username or password',
        errorLogin: 'Error trying to log in',
        duplicated: 'This city is already registered',
        cancel: 'Cancel',
        saveChanges: 'Save changes',
        userData: 'Personal data',
        okCity: 'City registered',
        koCity: 'Error registering the city',
        koConection: 'Error in the server connection', 
        okDeleteCity: 'City deleted',
        koDeleteCity: 'Error deleting the city',
        okResena: 'Review submitted',
        koResena: 'Error submitting review',
        okDeleteResena: 'Review deleted',
        koDeleteResena: 'Error deleting review',
        population: 'Population',
        country: 'Country',
        title: 'Title',
        description: 'Description',
        rating: 'Rating',
        isRecomended: 'Would you recommend this city to family and friends?',
        viewCities: 'Cities',
        addCity: 'Add city',
        register: 'Register',
        addResena: 'Add review'
    }
}

type MessageSchema = typeof messages['es']

const i18n = createI18n<[MessageSchema], 'es' | 'en'>({
    legacy: false,
    locale: 'es',
    fallbackLocale: 'en',
    messages
  })


const changeLanguage = (language: 'es' | 'en' ) => {
    i18n.global.locale = language
    localStorage.setItem('language', language)
}
  

const savedLanguage = localStorage.getItem('language')
    if (savedLanguage) {
    i18n.global.locale = savedLanguage as 'es' | 'en'
}


export default i18n
export { changeLanguage }