   <!-- JS FUNCTION FOR THE NAVBAR WHEN WE SCROLL -->

   <script type="text/javascript">
      window.addEventListener('scroll', function(){
        const header = document.querySelector('header');
        header.classList.toggle("sticky", window.scrollY > 0);
      });

      // JS FOR THE MENU TO CHANGE

      function toggleMenu(){
        const menuToggle = document.querySelector('.menuToggle');
        const navigation = document.querySelector('.navigation');
        menuToggle.classList.toggle('active');
        navigation.classList.toggle('active');
      }
    </script>
