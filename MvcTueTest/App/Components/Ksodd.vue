<template>
    <div class="crudksodd">
        <h1 class="crudheader text-uppercase">Cоздание новой карточки КСОДД</h1>

        <div class="ksoddbody">
            <v-row >
                <v-col>
                    <v-row>
                        <v-col cols="10" md="5">
                            <v-card tile flat>
                                <v-card-text>Наименование документа</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="10" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense clearable :rules="[rules.required]"></v-text-field>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="10" md="5">
                            <v-card tile flat>
                                <v-card-text>Наименование заказчика</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="10" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense clearable :rules="[rules.required]"></v-text-field>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="10" md="5">
                            <v-card tile flat>
                                <v-card-text>Федеральный округ</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="10" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense placeholder="Приволжский Федеральный округ" disabled></v-text-field>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Субъект РФ</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense placeholder="Республика чувашия" disabled></v-text-field>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Муниципальное образование</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense placeholder="Городской округ «Город Чебоксары»" disabled></v-text-field>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Наименование разработчика</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense clearable :rules="[rules.required]"></v-text-field>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Дата утверждения</v-card-text>
                            </v-card>
                        </v-col>
                        <!-- Дата проведения обследования -->
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <!-- <v-text-field dense clearable :rules="[rules.required]"></v-text-field> -->
                                <v-menu
                                        ref="menu"
                                        v-model="menu"
                                        :close-on-content-click="false"
                                        :nudge-right="40"
                                        :return-value.sync="date"
                                        lazy
                                        transition="scale-transition"
                                        offset-y
                                        full-width
                                        min-width="290px">
                                    <template v-slot:activator="{ on }">
                                        <v-text-field
                                                v-model="date"
                                                prepend-icon="mdi-calendar"
                                                readonly
                                                v-on="on" dense
                                                clearable :rules="[rules.required]"></v-text-field>
                                    </template>
                                    <v-date-picker v-model="date" no-title scrollable>
                                        <v-spacer></v-spacer>
                                        <v-btn flat color="primary" @click="menu = false">Cancel</v-btn>
                                        <v-btn flat color="primary" @click="$refs.menu.save(date)">OK</v-btn>
                                    </v-date-picker>
                                </v-menu>
                            </v-card>
                        </v-col>
                    </v-row>

                </v-col>
                <v-col>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Дата утверждения</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <!-- <v-text-field dense value="01.01.2020" clearable :rules="[rules.required]"></v-text-field> -->
                                <v-menu
                                        ref="menu"
                                        v-model="menu"
                                        :close-on-content-click="false"
                                        :nudge-right="40"
                                        :return-value.sync="date"
                                        lazy
                                        transition="scale-transition"
                                        offset-y
                                        full-width
                                        min-width="290px">
                                    <template v-slot:activator="{ on }">
                                        <v-text-field
                                                v-model="date"
                                                prepend-icon="mdi-calendar"
                                                readonly
                                                v-on="on" dense
                                                clearable :rules="[rules.required]"></v-text-field>
                                    </template>
                                    <v-date-picker v-model="date" no-title scrollable>
                                        <v-spacer></v-spacer>
                                        <v-btn flat color="primary" @click="menu = false">Cancel</v-btn>
                                        <v-btn flat color="primary" @click="$refs.menu.save(date)">OK</v-btn>
                                    </v-date-picker>
                                </v-menu>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Дата регистрации в системе</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-text-field dense value="01.01.2020" disabled prepend-icon="mdi-calendar"></v-text-field>


                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Добавить документ</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-file-input label="Добавить документ" clearable :rules="[rules.required]" chips></v-file-input>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card class="pa-2" flat>
                                <v-checkbox class="mx-2" label="Наличие транспортной модели" color="primary" v-model="transpModel"></v-checkbox>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row v-if="transpModel">
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Программное обеспечение, на котором разработана транспортная модель</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-combobox v-model="select" :items="items" multiple chips clearable :rules="[rules.required]"></v-combobox>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row v-if="transpModel">
                        <v-col cols="12" md="5">
                            <v-card tile flat>
                                <v-card-text>Загрузить транспортную модель</v-card-text>
                            </v-card>
                        </v-col>
                        <v-col cols="12" md="6">
                            <v-card class="pa-2" flat>
                                <v-file-input label="Добавьте документ транспортной модели" clearable chips show-size color="primary"></v-file-input>
                            </v-card>
                        </v-col>
                    </v-row>
                    <v-row>
                        <v-col cols="12" md="5">
                            <v-card class="pa-2" flat>
                                <v-checkbox v-model="disabled" class="mx-2" label="В составе единой КСОДД для агломерации" color="primary"></v-checkbox>
                            </v-card>
                        </v-col>
                    </v-row>
                </v-col>
            </v-row>
            <ksoddindicators></ksoddindicators>
        </div>
    </div>
</template>

<script>

    import ksoddindicators from '@/components/ksoddindicators'

    export default {
        components: {
            ksoddindicators,
        },
        data () {
            return {
                
                ksoddOpen: true,
                transpModel: false,
                level: [
                    'Уровень А',
                    'Уровень B',
                    'Уровень C',
                    'Уровень D',
                    'Уровень E',
                    'Уровень F',
                ],
                items: [
                    'Programming',
                    'Design',
                    'Vue',
                    'Vuetify',
                ],
                show1: false,
                show2: true,
                show3: false,
                show4: false,
                password: 'Password',
                rules: {
                    required: value => !!value || 'Поле обязательно для заполнения',
                    min: v => v.length >= 8 || 'Min 8 characters',
                    emailMatch: () => ('The email and password you entered don\'t match'),


                    date: new Date().toISOString().substr(0, 10),
                    menu: false,
                },
            }
        },

    }

</script>

<style lang="css">
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
    .crudheader {
        text-align: center;
        padding: 10px;
        /* background: #E3F2FD; */
    }
    .button_ksoddclose {
        position: fixed;
        bottom: 0;
        /* background-color: blue; */
        padding: 30px;
        cursor: pointer;
    }
</style>