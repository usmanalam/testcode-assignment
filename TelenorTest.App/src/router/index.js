import Vue from 'vue'
import Router from 'vue-router'
import CellPhones from '@/components/CellPhones'
import NotFound from '@/components/NotFound'
import PhoneSpecs from '@/components/PhoneSpecs'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      name: 'CellPhones',
      component: CellPhones
    },
    {
      path: '*',
      name: 'NotFound',
      component: NotFound
    },
    {
      path: '/phonespecs/:id',
      name: 'PhoneSpecs',
      component: PhoneSpecs
    }
  ]
})
