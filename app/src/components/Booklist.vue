<script>
import axios from 'axios';

export default {
  data() {
    return {
      books: [],
    };
  },
  async mounted() {
    const response = await axios.get('http://localhost:5232/api/Booklist');
    console.log(response.data[0]);
    this.books = response.data[0];
  },
};
</script>

<template>
  <div>
    <ul>
      <li>
        {{ books.bookname }}
      </li>
    </ul>
  </div>
</template>