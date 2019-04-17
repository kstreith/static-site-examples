var app = new Vue({
    el: '#app',
    data: {
        teams: []
    },
    mounted: function () {
        this.loadTeams();
    },
    methods: {
        loadTeams: function() {
            fetch('teams.json').then(response => response.json()).then(json => {
                app.data.teams = json;
              });
        }
    }
});