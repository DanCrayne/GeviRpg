<template>
  <div class="wrapper">

    <header class="main-header">
      <h1>{{ msg }}</h1>
    </header>

    <nav class="main-nav">
      <ul>
        <li><a href="">Link 1</a></li>
        <li><a href="">Link 2</a></li>
        <li><a href="">Link 3</a></li>
      </ul>
    </nav>

    <article class="content">
      <h1>Some content</h1>
      Main content text
    </article>

    <aside class="side">
      Side bar
    </aside>

    <footer class="main-footer">
      this is the footer
    </footer>

  </div>
</template>

<script>
export default {
  name: 'Home',
  props: {
    msg: String
  }
}
</script>

<style scoped>

nav ul {
  padding: 0;
}

* {
  border: solid 1px;
  margin: 1px;
}

.wrapper {
  display: grid;
  grid-gap: 5px;
  grid-template-areas:
    "header"
    "nav"
    "content"
    "sidebar"
    "footer";

  min-width: 320px;
}

@media (min-width: 500px) {
  .wrapper {
    grid-template-columns: 1fr 3fr;
    grid-template-areas:
      "header   header"
      "nav      nav"
      "sidebar  content"
      "footer   footer";
  }

  nav ul {
    display: flex;
    justify-content: space-between;
  }
}

@media (min-width: 700px) {
  .wrapper {
    grid-template-columns: 1fr 4fr 1fr;
    grid-template-areas:
      "header   header    header"
      "nav      content   sidebar"
      "footer   footer    footer";
  }

  nav ul {
    flex-direction: column;
  }
}

.main-header {
  grid-area: header;
}

.main-nav {
  grid-area: nav;
}

.main-nav ul {
  list-style-type: none;
}

.content {
  grid-area: content;
}

.side {
  grid-area: sidebar;
}

.main-footer {
  grid-area: footer;
}
</style>