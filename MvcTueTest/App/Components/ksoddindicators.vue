<template>
    <div class="indicators">
        <v-expansion-panels
                v-model="panel"
                :disabled="disabled"
                :flat="false"
                :hover="hover"
                :focusable="focusable"
                :tile="true"
        >
            <v-expansion-panel>
                <v-expansion-panel-header>
                    <h2 class="text-uppercase">Блок показателей</h2>
                </v-expansion-panel-header>
                <v-expansion-panel-content>
                    <h3 class="indicatorsheader text-uppercase">Cуществующие и запланированные показатели уровня безопасности дорожного движения</h3>
                    <div class="indicatorsbody">
                        <v-row>
                            <v-col>
                                <v-row>
                                    <v-col cols="12" md="5">
                                        <v-card tile flat>
                                            <v-card-text>Количество дорожно-транспортных происшествий (план)</v-card-text>
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
                                            <v-card-text>Количество погибших (план)</v-card-text>
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
                                            <v-card-text>Количество раненых (план)</v-card-text>
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
                                            <v-card-text>Количество погибших на 100 тыс. чел. населения (план)</v-card-text>
                                        </v-card>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-card class="pa-2" flat>
                                            <v-text-field dense clearable :rules="[rules.required]"></v-text-field>
                                        </v-card>
                                    </v-col>
                                </v-row>

                            </v-col>
                            <v-col>
                                <v-row>
                                    <v-col cols="12" md="5">
                                        <v-card tile flat>
                                            <v-card-text>Количество дорожно-транспортных происшествий (факт)</v-card-text>
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
                                            <v-card-text>Количество погибших (факт)</v-card-text>
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
                                            <v-card-text>Количество раненых (факт)</v-card-text>
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
                                            <v-card-text>Количество погибших на 100 тыс. чел. населения (факт)</v-card-text>
                                        </v-card>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-card class="pa-2" flat>
                                            <v-text-field dense clearable :rules="[rules.required]"></v-text-field>
                                        </v-card>
                                    </v-col>
                                </v-row>
                            </v-col>
                        </v-row>
                        <h3 class="indicatorsheader text-uppercase">Другие показатели</h3>
                        <v-row>
                            <!--                        Колонка 1-->
                            <v-col>
                                <v-row>
                                    <v-col cols="12" md="5">
                                        <v-card tile flat>
                                            <v-card-text>Интенсивность дорожного движения (приведенные единицы), факт</v-card-text>
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
                                            <v-card-text>Буферный индекс (единицы), факт</v-card-text>
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
                                            <v-card-text>Средняя скорость движения транспортных средств, усредненная по территории разработки КСОДД (км/ч), факт</v-card-text>
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
                                            <v-card-text>Средняя задержка (час/авт. в сутки), факт</v-card-text>
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
                                            <v-card-text>Временный индекс (единица), факт</v-card-text>
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
                                            <v-card-text>Уровень обслуживания дорожного движения в территории разработки КСОДД (уровень по шкале), факт</v-card-text>
                                        </v-card>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-card class="pa-2" flat>
                                            <v-combobox
                                                    chips
                                                    clearable
                                                    :rules="[rules.required]"
                                                    v-model="select"
                                                    :items="level"
                                            ></v-combobox>

                                        </v-card>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col cols="12" md="5">
                                        <v-card tile flat>
                                            <v-card-text>
                                                Показатель перегруженности дорог территории разработки КСОДД (единица), факт
                                            </v-card-text>
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
                                            <v-card-text>Финансовое обеспечение реализации мероприятий по организации
                                                и безопасности дорожного движения (объем финансирования)
                                            </v-card-text>
                                        </v-card>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-card class="pa-2" flat>
                                            <v-text-field dense clearable :rules="[rules.required]"></v-text-field>
                                        </v-card>
                                    </v-col>
                                </v-row>
                            </v-col>
                            <!--                        Колонка 2 -->
                            <v-col>
                                <v-row>
                                    <v-col cols="12" md="5">
                                        <v-card tile flat>
                                            <v-card-text>Интенсивность дорожного движения (приведенные единицы), план</v-card-text>
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
                                            <v-card-text>Буферный индекс (единицы), план</v-card-text>
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
                                            <v-card-text>Средняя скорость движения транспортных средств, усредненная по территории разработки КСОДД (км/ч), план</v-card-text>
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
                                            <v-card-text>Средняя задержка (час/авт. в сутки), план</v-card-text>
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
                                            <v-card-text>Временный индекс (единица), план</v-card-text>
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
                                            <v-card-text>Уровень обслуживания дорожного движения в территории разработки КСОДД (уровень по шкале), план</v-card-text>
                                        </v-card>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-card class="pa-2" flat>
                                            <v-combobox
                                                    chips
                                                    clearable
                                                    :rules="[rules.required]"
                                                    v-model="select"
                                                    :items="level"
                                            ></v-combobox>

                                        </v-card>
                                    </v-col>
                                </v-row>
                                <v-row>
                                    <v-col cols="12" md="5">
                                        <v-card tile flat>
                                            <v-card-text>
                                                Показатель перегруженности дорог территории разработки КСОДД (единица), план
                                            </v-card-text>
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
                                            <v-card-text>
                                            </v-card-text>
                                        </v-card>
                                    </v-col>
                                    <v-col cols="12" md="6">
                                        <v-card class="pa-2" flat>
                                        </v-card>
                                    </v-col>
                                </v-row>
                            </v-col>
                        </v-row>
                    </div>
                </v-expansion-panel-content>
            </v-expansion-panel>
        </v-expansion-panels>
    </div>
    <!-- </v-container> -->
</template>

<script>

    export default {



        data () {
            return {
                ksoddindicators: false,
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

<style>

    .indicators {
        position: relative;
        padding: 10px;
        width: 100%;
        overflow: auto;
    }
    .indicatorsheader {
        text-align: center;
        margin: 0;
    }
    .indicatorsbody {
        overflow: auto;
    }
    .crudheader {
        text-align: center;
        padding: 20px;
    }
    h2 {
        text-align: center;
    }
</style>