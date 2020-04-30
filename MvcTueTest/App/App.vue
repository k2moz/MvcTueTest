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
            <v-btn color="error" v-on:click="GetUser">GetUser</v-btn>
        </v-app-bar>
        <p id="user"></p>

        <v-content>
            <div class="my-2 button_docpanelshow">
                <v-btn color="primary" fab small dark @click="docPanelShow =! docPanelShow">
                    <v-icon>mdi-file-document</v-icon>
                </v-btn>
            </div>

            <!-- <tabs v-if="docPanelShow"></tabs> -->
            <panel v-if="docPanelShow"></panel>
        </v-content>

    </v-app>
</template>

<script>
    import Panel from '@/components/Panel'
    // import panel from '@/components/ksodd'
    // import tabs from '@/components/tabs'

    export default {
        name: 'App',

        components: {
            Panel,
            // ksodd,
            // tabs
        },

        data: () => ({
            docPanelShow: false,
        }),
        methods: {
            GetUser: () => {
                console.log("GetUser");
                var xhttp = new XMLHttpRequest();
                xhttp.onreadystatechange = function () {
                    if (this.readyState === 4 && this.status === 200) {
                        document.getElementById("user").innerHTML =
                            this.responseText;
                    }
                };
                xhttp.open("GET", "https://localhost:5001/Home/GetUser", true);
                xhttp.send();
            },
        }

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

