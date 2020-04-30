<template>
    <v-app>
        <v-app-bar app color="white" dark>
            <div class="d-flex align-center">
                <v-img
                        class="shrink mr-2"
                        contain
                        src="http://10.0.0.125:8005/favicon.ico"
                        transition="scale-transition"
                        width="40"
                />
            </div>

            <v-spacer></v-spacer>

            <!--<v-btn-->
                    <!--href="https://github.com/vuetifyjs/vuetify/releases/latest"-->
                    <!--target="_blank"-->
                    <!--text-->
            <!--&gt;-->
                <!--<span class="mr-2">Latest Release</span>-->
                <!--<v-icon>mdi-open-in-new</v-icon>-->
            <!--</v-btn>-->
            <v-btn color="error" v-on:click="peopleTable = !peopleTable">GetUser</v-btn>
            <v-btn color="success" v-on:click="carTable = !carTable">GetCar</v-btn>
        </v-app-bar>
        <p id="user"></p>
        <p id="car"></p>
        <v-simple-table v-if="carTable" dark>
            <template >
                <thead>
                <tr>
                    <th class="text-left">Id</th>
                    <th class="text-left">Name</th>
                    <th class="text-left">Model</th>
                </tr>
                </thead>
                <tbody>
                <tr v-for="car in cars" :key="car.id">
                    <td>{{ car.id }}</td>
                    <td>{{ car.name }}</td>
                    <td>{{ car.model }}</td>
                </tr>
                </tbody>
            </template>
        </v-simple-table>


        <v-simple-table fixed-header height="300px" v-if="peopleTable">
            <template>
                <thead>
                <tr>
                    <th class="text-left">Id</th>
                    <th class="text-left">FirstName</th>
                    <th class="text-left">LastName</th>
                </tr>
                </thead>
                <tbody>
                <tr v-for="person in people" :key="people.id">
                    <td>{{ person.id }}</td>
                    <td>{{ person.firstName }}</td>
                    <td>{{ person.lastName }}</td>
                </tr>
                </tbody>
            </template>
        </v-simple-table>

        <!--<v-content>-->
            <!--<div class="my-2 button_docpanelshow">-->
                <!--<v-btn color="primary" fab small dark @click="docPanelShow =! docPanelShow">-->
                    <!--<v-icon>mdi-file-document</v-icon>-->
                <!--</v-btn>-->
            <!--</div>-->

            <!--&lt;!&ndash; <tabs v-if="docPanelShow"></tabs> &ndash;&gt;-->
            <!--<panel v-if="docPanelShow"></panel>-->
        <!--</v-content>-->

    </v-app>
</template>

<script>
    // import Panel from '@/components/Panel'
    // import panel from '@/components/ksodd'
    // import tabs from '@/components/tabs'

    export default {
        name: 'App',
        components: {
            // Panel,
            // ksodd,
            // tabs
        },

        data: () => ({
            docPanelShow: false,
            carTable: false,
            peopleTable: false,
            people: [],
            cars: []
        }),
        
        mounted() {
          fetch("https://localhost:5001/Car/GetCar")
              .then(response => response.json())
              .then((data) => {
                  this.cars = data;
              });
          fetch("https://localhost:5001/Home/GetUser")
              .then(response => response.json())
              .then((data) => {
                  this.people = data;
              });
        },
        
        
        
        methods: {
            // GetUser: () => {
            //     console.log("GetUser");
            //     var xhttp = new XMLHttpRequest();
            //     xhttp.onreadystatechange = function () {
            //         if (this.readyState === 4 && this.status === 200) {
            //             document.getElementById("user").innerHTML =
            //                 this.responseText;
            //         }
            //     };
            //     xhttp.open("GET", "https://localhost:5001/Home/GetUser", true);
            //     xhttp.send();
            // },

            

            GetCar: () => {
                console.log("GetCar");
                let url = "https://localhost:5001/Car/GetCar";
                $.getJSON(url).done(function (data) {
                    console.log(data);
                });
                
                // console.log("GetCar");
                // var xhttp = new XMLHttpRequest();
                // xhttp.onreadystatechange = function () {
                //     if (this.readyState === 4 && this.status === 200) {
                //         document.getElementById("car").innerHTML =
                //             this.responseText;
                //     }
                // };
                // xhttp.open("GET", "https://localhost:5001/Car/GetCar", true);
                // xhttp.send();
            },
            
            
        },

    };
</script>

<style lang="css">
    .button_docpanelshow {
        position: fixed;
        bottom: 0;
        /* background-color: blue; */
        padding: 30px;
        cursor: pointer;
    }

</style>

