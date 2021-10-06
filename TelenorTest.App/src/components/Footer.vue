<template>
<footer class="pt-4 my-md-5 pt-md-5 border-top">
      <div class="row">
          <div class="col-12 col-md">
            <img class="mb-2" src="../assets/telenor.png" alt="" width="70" height="70">
            <small class="d-block mb-3 text-muted">© {{ new Date().getFullYear() }}</small>
          </div>
          <div class="col-6 col-md">
            <h5>Log in</h5>
            <ul class="list-unstyled text-small">
              <li><a class="text-muted" href="#">Cool stuff</a></li>
              <li><a class="text-muted" href="#">My Pages</a></li>
              <li><a class="text-muted" href="#">Support</a></li>
            </ul>
          </div>
          <div class="col-6 col-md">
            <h5>Shopping Info</h5>
            <ul class="list-unstyled text-small">
              <li><a class="text-muted" href="#">Prices</a></li>
              <li><a class="text-muted" href="#">Return & Change</a></li>
              <li><a class="text-muted" href="#">Shipping</a></li>
              <li><a class="text-muted" href="#">Contact us</a></li>
            </ul>
          </div>
          <div class="col-6 col-md">
            <h5>About</h5>
            <ul class="list-unstyled text-small">
              <li><a class="text-muted" href="#">Team</a></li>
              <li><a class="text-muted" href="#">Locations</a></li>
              <li><a class="text-muted" href="#">Privacy</a></li>
              <li><a class="text-muted" href="#">Terms</a></li>
            </ul>
          </div>
        </div>
</footer>
</template>
<script>
export default {
  name: 'Footer'
}
</script>
<style scoped>
.footer {
    padding: 20px;
    background: #17A2B8;
    color: white;
    bottom: 0;
    left: 0;
    right: 0;
    margin-top: 70px;
}
</style>
