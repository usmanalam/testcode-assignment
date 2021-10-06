<template>
   <div class="home-container">
        <div class="card-deck mb-3 text-center">
            <div class="card mb-4 shadow-sm" v-for="phone in phonelist" :key="phone.id">
            <div class="card-header">
                <h4 class="my-0 font-weight-normal">{{ phone.name }}</h4>
            </div>
            <div class="card-body">
                <h1 class="card-title pricing-card-title">SEK {{ phone.price }} <small class="text-muted">/ mo</small></h1>
                <ul class="list-unstyled mt-3 mb-4">
                <li>{{ phone.campaign.domesticCalls }} in Sweden</li>
                <li>{{ phone.campaign.domesticSMS }} in Sweden</li>
                <li>{{ phone.campaign.domesticDataSurf }}</li>
                <li>{{ phone.campaign.roamingDataSurf }}</li>
                </ul>
                <p>{{ phone.description }}</p>
                <button type="button" @click="goToSpecs(phone.id)" class="btn btn-lg btn-block btn-outline-primary">Buy</button>
            </div>
            </div>
        </div>
   </div>
</template>

<script>
import cellphoneService from '@/services/cellphones.service'

export default {
  name: 'cellphones',
  data () {
    return {
      phonelist: []
    }
  },
  created () {
    cellphoneService.getAll().then((response) => {
      this.phonelist = response.data
    }).catch((error) => {
      console.log(error.response.data)
    })
  },
  methods: {
    goToSpecs (pId) {
      this.$router.push({name: 'PhoneSpecs', params: {id: pId}})
    }
  }
}
</script>

<style scoped>
.home-container {
    position: relative;
    top:30px;
}
</style>
