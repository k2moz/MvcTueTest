<template>
    <div id="home">
        <h1>{{message}}</h1>
        <table-test />
    </div>
</template>

<script>
    import TableTest from '@/Components/TableTest'
        

    export default {
            data() {
                return {
                    message: 'Welcome to Vue.js',
                }
            },
            components: {
                TableTest
            }
        }
</script>

<style lang="scss">
</style>