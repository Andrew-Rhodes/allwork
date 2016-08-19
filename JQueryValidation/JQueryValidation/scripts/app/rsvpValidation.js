$(document)
    .ready(function() {
        $('rsvpForm')
            .validate({
                rules: {
                    Name: {
                        required: true
                    },
                    Email: {
                        required: true,
                        email: true
                    },
                    Phone: {
                        required: true
                    },
                    FavoriteGame: {
                        required: true,
                        minlength: 3
                    },
                    WillAttened: {
                        required: true
                    }
                },
                messages: {
                    Name: "Enter your name",
                    Email: {
                        required: "Enter your email address",
                        email: "Thats not a vaild email"
                    },
                    Phone: "Enter youre phone number",
                    FavoriteGame: {
                        required: "Tell me what your favorite game is",
                        minlength: $.validator.format("I dont know of any game with less that {0} characters...")

                    },
                    WillAttened: "I need to know if youre coming or not"
                }
            });
    });