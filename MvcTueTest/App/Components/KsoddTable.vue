<template>
    <v-simple-table :fixed-header="fixedHeader">
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
            <!--<tr v-for="ksodd in ksodds" :key="ksodd.id">-->
            <tr v-for="ksodd in ksodds" :key="ksodd.id">
                <td>{{ ksodd.id }}</td>
                <td>{{ ksodd.name }}</td>
                <td>{{ ksodd.ownerName }}</td>
                <td>{{ ksodd.nameDeveloper}}</td>
                <td>{{ ksodd.dateApproval }}</td>
                <td>{{ ksodd.dateRegistration }}</td>
                <td>{{ ksodd.endDate }}</td>
            </tr>
            </tbody>
            <v-footer fixed width="80%" class="elevation-1" color="#FFFFFF">
                <v-btn class="primary" @click="GetKsodd">Вернуть json</v-btn>
            </v-footer>
        </template>
    </v-simple-table>
</template>

<script>
// slajdlkasjdlkasjd
// check
    export default {
        data: () => ({
            fixedHeader: true,
            ksodds: []
        }),
        
        
        // created() {
        //     this.GetKsodd();
        // },

        // mounted: function () {
        //     $.getJSON("https://localhost:5001/Ksodd/GetKsodd").done((data) => {
        //         this.ksodds = data;
        //         console.log(data);
        //     });
        // },
        
        methods: {
            GetKsodd() {
                $.getJSON("https://localhost:5001/Ksodd/GetKsodd").done((data) => {
                    this.ksodds = data;
                    console.log(data);
                });
            },
        }
        
        
        
        
        
        
        //methods: {
        //    GetKsodd: () => {
        //        $.getJSON()
        //    }
        //}
        // mounted() {
        //     axios
        //         .get("https://localhost:5001/Ksodd/GetKsodd")
        //         .then(response => (this.ksodds = response));
        //    
        //     // fetch("https://localhost:5001/Ksodd/GetKsodd")
        //     //     .then(response => response.json())
        //     //     .then((data) => {
        //     //         this.ksodds = data;
        //     //     });
        // },
        // methods: {
        //     GetKsodd: () => {
        //         console.log("GetKsodd");
        //         let url = "https://localhost:5001/Ksodd/GetKsodd";
        //         $.getJSON(url).done(function (data) {
        //             console.log(data);
        //         });
        //     }
        // }
        
        
        
    }
</script>

<style lang="css" scoped>

</style>