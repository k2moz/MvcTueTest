<template>
    <!--    <v-card>-->
    <!-- <v-toolbar flat color="primary" dark>
      <v-toolbar-title>User Profile</v-toolbar-title>
    </v-toolbar> -->
    <v-tabs >
        <v-tab>
            <!-- <v-icon left>mdi-account</v-icon> -->
            КСОДД
        </v-tab>
        <v-tab>
            <!-- <v-icon left>mdi-lock</v-icon> -->
            ПОДД
        </v-tab>
        <v-tab>
            ОДД (Стационарные посты учета)
        </v-tab>
        <v-tab>
            ОДД (КТС)
        </v-tab>
        <v-tab>
            Автомобильные дороги
        </v-tab>
        <!-- вкладка КСОДД -->
        <v-tab-item>
            <v-card flat>
                <ksodd v-if="ksoddVisible"></ksodd>
                <v-card-text>
                    <ksoddtable></ksoddtable>
                </v-card-text>
            </v-card>

        </v-tab-item>

        <!-- вкладка ПОДД -->
        <v-tab-item>
            <v-card flat>
                <v-card-text>
                    <poddtable></poddtable>
                </v-card-text>
            </v-card>

        </v-tab-item>
        <!--      ОДД Стационарные посты учета-->
        <v-tab-item>
            <v-card flat>
                <v-card-text>
                    <odd-spu></odd-spu>
                </v-card-text>
            </v-card>
        </v-tab-item>
        <!--      ОДД КТС-->
        <v-tab-item style="overflow-x: auto">
            <v-card flat>
                <v-card-text>
                    <ktstable></ktstable>
                </v-card-text>
            </v-card>

        </v-tab-item>
        <!--      Автодороги -->
        <v-tab-item>
            <v-card flat>

            </v-card>
        </v-tab-item>
    </v-tabs>
    <!--    </v-card>-->
</template>

<script>

    import Ksoddtable from '@/components/Ksoddtable'
    import Poddtable from '@/components/Poddtable'
    import OddSpu from '@/components/OddSpu'
    import Ktstable from '@/components/Ktstable'
    import Ksodd from '@/components/Ksodd'
    export default {
        components: {
            Ksoddtable,
            Poddtable,
            OddSpu,
            Ktstable,
            Ksodd
        },
        data () {
            return {
                ksoddVisible: false
            }
        }
    }
</script>

<style scoped>
    .tabsvue {
        height: 100%;

        /*margin: 5px;*/
    }
    /*.footer {*/
    /*    position: relative;*/
    /*    border: dotted gray 0.25px;*/
    /*    height: 100%;*/
    /*    width: 100%;*/
    /*}*/
    .ksoddbody {
        margin: 0;
        padding: 0;
    }
    .crudksodd {
        position: relative;
        height: 100%;
        padding: 10px;
        margin-bottom: 30px;

    }

    .button_ksoddclose {
        position: fixed;
        bottom: 0;
        /* background-color: blue; */
        padding: 30px;
        cursor: pointer;
    }
</style>