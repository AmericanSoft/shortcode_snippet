<?php 
# Remove Logo Accelerator
function remove_logo_accelerator() {
    ?>
    <script>
        document.addEventListener("DOMContentLoaded", function() {
            const logo_accelerator = document.querySelector('a[href="https://www.s-sols.com/products/wordpress/accelerator?utm_source=usersite&utm_medium=banner&utm_campaign=free_lim_ver&utm_term=accel"]');
            if (logo_accelerator) {
                logo_accelerator.remove();
            }
        });
    </script>
    <?php
}
add_action('wp_footer', 'remove_logo_accelerator');
