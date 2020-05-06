<template>
    <!-- <v-app id="inspire"> -->

    <div class="docpanel" v-if="isVisible">
        <v-btn text @click="isVisible =!isVisible">
            <!-- <v-icon>md-chevron-down</v-icon> -->
            <v-icon>mdi-menu-down</v-icon>
            <span>Свернуть</span>
        </v-btn>
        <!--            <ksodd></ksodd>-->
        <v-container>
            <tabs></tabs>
        </v-container>
    </div>
    <!-- </v-app> -->
</template>

<script>

    // import ksodd from '@/components/ksodd'
    import Tabs from '@/components/Tabs'

    export default {
        components: {
            // ksodd,
            Tabs

        },


        data () {
            return {
                isVisible: true
            }
        },
    }

</script>

<style lang="css">
    * {
        font-family: Roboto Condensed,sans-serif!important;

    }
    .ksoddbody {
        overflow: auto;
        height: 100%;
        padding: 20px;
    }
    .docpanel {
        position: fixed;
        bottom: 0;
        box-shadow: -2px 0 10px 0 #b5b5b5;
        background-color: #fff;
        border-color: #e7e7e7;
        height: 80%;
        width: 100%;
        flex-direction: column;
        z-index: 1;
    }

    .indicators {
        padding: 10px;
        width: 100%;
        margin-bottom: 200px;
        overflow: auto;
    }
    .indicatorsheader {
        text-align: center;
        margin: 30px;
    }
    .crudheader {
        text-align: center;
        padding: 20px;
        /* border: dotted gray 0.25px; */
    }
</style>