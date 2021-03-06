<template>
  <v-app id="keep">
    <v-app-bar app clipped-left color="blue-grey darken-4">
      <v-app-bar-nav-icon
        @click="drawer = !drawer"
        color="white"
      ></v-app-bar-nav-icon>
      <span class="title ml-3 mr-5"
        ><img src="./img/logo-white.png" alt=""
      /></span>
      <div class="flex-grow-1"></div>
    </v-app-bar>

    <v-navigation-drawer v-model="drawer" app clipped>
      <v-list dense>
        <template>
          <v-list-item v-if="authenticated" :to="{ name: routeNames.requests }">
            <v-list-item-action>
              <v-icon>mdi-google-chrome</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text">Requests</v-list-item-title>
          </v-list-item>
          <v-divider dark class="my-4" v-if="authenticated"></v-divider>
          <v-list-item v-if="authenticated" :to="{ name: routeNames.stubs }">
            <v-list-item-action>
              <v-icon>mdi-controller-classic</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text">Stubs</v-list-item-title>
          </v-list-item>
          <v-list-item v-if="authenticated" :to="{ name: routeNames.stubForm }">
            <v-list-item-action>
              <v-icon>mdi-plus</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text">Add stubs</v-list-item-title>
          </v-list-item>
          <v-list-item
            v-if="authenticated"
            :to="{ name: routeNames.uploadStub }"
          >
            <v-list-item-action>
              <v-icon>mdi-plus</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text"
              >Upload stubs</v-list-item-title
            >
          </v-list-item>
          <v-list-item
            v-if="authenticated"
            :to="{ name: routeNames.downloadStubs }"
          >
            <v-list-item-action>
              <v-icon>mdi-download</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text"
              >Download stubs
            </v-list-item-title>
          </v-list-item>
          <v-divider dark class="my-4" v-if="authenticated"></v-divider>
          <v-list-item v-if="authenticated" :to="{ name: routeNames.settings }">
            <v-list-item-action>
              <v-icon>mdi-cogs</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text">Settings</v-list-item-title>
          </v-list-item>
          <v-divider
            dark
            class="my-4"
            v-if="authenticated && authRequired"
          ></v-divider>
          <v-list-item @click="logout" v-if="authenticated && authRequired">
            <v-list-item-action>
              <v-icon>mdi-exit-to-app</v-icon>
            </v-list-item-action>
            <v-list-item-title class="grey--text">Log out</v-list-item-title>
          </v-list-item>
        </template>
      </v-list>
    </v-navigation-drawer>

    <v-main>
      <v-container fluid class="lighten-4">
        <router-view :key="$route.fullPath"></router-view>
      </v-container>
    </v-main>
  </v-app>
</template>

<script>
import { routeNames } from "@/router/routerConstants";
import { getDarkThemeEnabled } from "@/utils/sessionUtil";

export default {
  name: "app",
  beforeMount() {
    this.setTheme();
  },
  async created() {
    this.metadata = await this.$store.dispatch("metadata/getMetadata");
    document.title = `HttPlaceholder - v${this.metadata.version}`;

    if (!this.authenticated) {
      this.authRequired = await this.$store.dispatch(
        "users/ensureAuthenticated"
      );
    }
  },
  data() {
    return {
      drawer: true,
      authRequired: false,
      routeNames
    };
  },
  computed: {
    authenticated() {
      return this.$store.getters["users/getAuthenticated"];
    },
    darkTheme() {
      return this.$store.getters["general/getDarkTheme"];
    }
  },
  methods: {
    logout() {
      this.$store.commit("users/storeUserToken", null);
      this.$router.push({ name: routeNames.login });
    },
    setTheme() {
      const darkThemeEnabled = getDarkThemeEnabled();
      if (darkThemeEnabled) {
        this.$store.commit("general/storeDarkTheme", darkThemeEnabled);
      }
    }
  },
  watch: {
    darkTheme(darkTheme) {
      this.$vuetify.theme.dark = darkTheme;
    }
  }
};
</script>

<style scoped>
.title img {
  position: absolute;
  top: 8px;
  height: 70%;
}
</style>
