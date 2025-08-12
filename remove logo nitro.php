function remove_specific_link() {
    ?>
    <script>
        document.addEventListener("DOMContentLoaded", function() {
            const link = document.querySelector('div[class="wNzIMwYuNNZUjYcmTjN0QdjD5gND4Ei wNzIMwYuNNZUjYcmTjN0QdjD5gND4Eitheme--light"]');
            if (link) {
                link.remove();
            }
        });
    </script>
    <?php
}
add_action('wp_footer', 'remove_specific_link');
