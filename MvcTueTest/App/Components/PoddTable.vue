<template xmlns:v-slot="http://www.w3.org/1999/XSL/Transform">
    <v-simple-table>
        <template>
            <thead>
            <tr>
                <th class="text-left">Ид</th>
                <th class="text-left">Наименование</th>
                <th class="text-left">Наименование заказчика</th>
                <th class="text-left">Наименование разработчика</th>
                <th class="text-left">Дата утверждения</th>
                <th class="text-left">Дата регистрации в системе</th>
                <th class="text-left">Срок действия документа</th>
            </tr>
            </thead>
            <tbody>
            <tr v-for="podd in podds" :key="podd.id">
                <td>{{ podd.id }}</td>
                <td>{{ podd.name }}</td>
                <td>{{ podd.ownerName }}</td>
                <td>{{ podd.nameDeveloper}}</td>
                <td>{{ podd.dateApproval }}</td>
                <td>{{ podd.dateRegistration }}</td>
                <td>{{ podd.endDate }}</td>
            </tr>
            </tbody>
            <v-footer fixed width="80%" class="elevation-1" color="#FFFFFF">
                <v-btn class="primary" @click="">PUSHIK</v-btn>
            </v-footer>
        </template>
    </v-simple-table>


</template>


<script>
    export default {
        
        data: () => ({
            podds: []
        }),

        mounted: function () {
            $.getJSON("https://localhost:5001/Podd/GetPodd").done((data) => {
                this.podds = data;
                console.log(data);
            });
        },

    }
</script>

<style scoped>

</style>