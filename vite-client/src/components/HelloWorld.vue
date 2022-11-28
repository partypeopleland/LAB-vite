<script setup>
import {reactive, ref} from 'vue'

defineProps({
    msg: String
})


const state = reactive({
    count: ref(0),
    msg: 'empty'
})


fetch("https://localhost:7190/test")
    .then(r => r.text())
    .then(t => state.msg = t)

</script>

<template>
    <h1>{{ msg }}</h1>
    <h3>{{ state.msg }}</h3>

    <div class="card">
        <button type="button" @click="state.count++">count is {{ state.count }}</button>
        <p>
            Edit
            <code>components/HelloWorld.vue</code> to test HMR
        </p>
    </div>
</template>

<style scoped>
.read-the-docs {
    color: #888;
}
</style>
