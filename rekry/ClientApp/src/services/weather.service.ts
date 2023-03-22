import {networkRequestError, weatherData} from '@/types'
import axios, {AxiosResponse} from 'axios'

export async function getWeather(n = 4): Promise<weatherData[] | networkRequestError> {
    const url = "https://localhost:7033/weatherforecast/"
    try {
        const response = await axios.get<weatherData[]>(url, {params: {n}})
        return response.data
    } catch (error) {
        return new networkRequestError(error)
    }

}
