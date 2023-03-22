<script setup lang="ts">
import { ref } from 'vue'
import { weatherService } from '@/services'
import { networkRequestError, weatherData } from '@/types'

defineProps<{ msg: string }>()

const forecast = ref<weatherData[]>()
async function getForecast() {
  const value = await weatherService.getWeather()
  if (!(value instanceof networkRequestError)) {
    forecast.value = value
  } else {
    console.error(value.message)
  }
}
</script>

<template>
  <h1>{{ msg }}</h1>
  <button class="forecast-button" type="button" @click="getForecast">Get forecast</button>
	<p v-if="forecast">| Pori | Tampere | Helsinki | Vaasa | Lappeenranta |</p>
	<div class="container">
    <div class="weather" v-for="weather in forecast" :key="weather.city" >
      <h3>{{weather.city}}</h3>
      {{weather.temperatureF}}&deg;F {{weather.summary}}
    </div>
  </div>

</template>

<style scoped>
a {
  color: #42b983;
}

label {
  margin: 0 0.5em;
  font-weight: bold;
}

code {
  background-color: #eee;
  padding: 2px 4px;
  border-radius: 4px;
  color: #304455;
}

.container {
  display: flex;
  justify-content: center;
}
.weather {
  border-color: black;
  border-style: solid;
  border-radius: 25px;
  margin: 5px;
  padding-bottom: 6px;
  padding-left: 5px;
  padding-right: 5px;
  width: 110px;
}

.forecast-button {
  margin: 10px;
  font-size: large;
  color: white;
  background-color: #42b983;
  border-style: none;
  padding: 10px 13px;
  border-radius: 10px;
}
</style>
