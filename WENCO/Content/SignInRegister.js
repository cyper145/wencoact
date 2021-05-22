(function () {

    var minPwdLength = 2;
    var strongPwdLength = 8;
    function UpdateIndicator() {
        var strength = GetPasswordStrength(tbPassword.GetText());

        var className;
        var message;
        if (strength == -1) {
            className = 'pwdBlankBar';
            message = "Empty";
        } else if (strength == 0) {
            className = 'pwdBlankBar';
            message = "Too short";
        } else if (strength <= 0.2) {
            className = 'pwdWeakBar';
            message = "Weak";
        } else if (strength <= 0.6) {
            className = 'pwdFairBar';
            message = "Fair";
        } else {
            className = 'pwdStrengthBar';
            message = "Strong";
        }

        // update css and message
        var bar = document.getElementById("PasswordStrengthBar");
        bar.className = className;
        lbMessagePassword.SetValue(message);
    }
    function GetPasswordStrength(password) {
        if (password.length == 0) return -1;
        if (password.length < minPwdLength) return 0;

        var rate = 0;
        if (password.length >= strongPwdLength) rate++;
        if (password.match(/[0-9]/)) rate++;
        if (password.match(/[a-z]/)) rate++;
        if (password.match(/[A-Z]/)) rate++;
        if (password.match(/[!,@,#,$,%,^,&,*,?,_,~,\-,(,),\s,\[,\],+,=,\,,<,>,:,;]/)) rate++;
        return rate / 5;
    }


    function onPasswordButtonEditButtonClick(s, e) {
        var inputType = s.GetInputElement().type;
        var turnOnPasswordMode = inputType !== "password";

        s.GetInputElement().type = turnOnPasswordMode ? "password" : "text";

        var eyeButton = s.GetMainElement().getElementsByClassName("eye-button")[0];
        if (turnOnPasswordMode)
            ASPxClientUtils.RemoveClassNameFromElement(eyeButton, "show-password");
        else
            ASPxClientUtils.AddClassNameToElement(eyeButton, "show-password");

        //
       
        
      //  
      //  console.log(eyeButtonda);
      //  alert(eyeButtonda);

    }

    function onPasswordTextChanged(s,e) {
     //   alert("holas");

        var password = s.GetInputElement().value;
        console.log(e);
        let className = isPasswordSimple(password);
        console.log(className);
        var eyeButtonda = s.GetInputElement().parentNode;
        console.log(eyeButtonda);

        if (eyeButtonda.classList.contains("pwdBlankBar")) {
            eyeButtonda.classList.remove("pwdBlankBar")
        }
        if (eyeButtonda.classList.contains("pwdWeakBar")) {
            eyeButtonda.classList.remove("pwdWeakBar")
        }
        if (eyeButtonda.classList.contains("pwdFairBar")) {
            eyeButtonda.classList.remove("pwdFairBar")
        }
        if (eyeButtonda.classList.contains("pwdStrengthBar")) {
            eyeButtonda.classList.remove("pwdStrengthBar")
        }
        eyeButtonda.classList.add(className)
        console.log(eyeButtonda);
    }

    function isPasswordSimple(password) {
       // var passwordMinLength = 8;
       // return password.length > 0 && password.length < passwordMinLength;

        var strength = GetPasswordStrength(password);

        var className;
        var message;
        if (strength == -1) {
            className = 'pwdBlankBar';
            message = "vacio";
        } else if (strength == 0) {
            className = 'pwdBlankBar';
            message = "muy corto";
        } else if (strength <= 0.2) {
            className = 'pwdWeakBar';
            message = "Debíl";
        } else if (strength <= 0.6) {
            className = 'pwdFairBar';
            message = "Justo";
        } else {
            className = 'pwdStrengthBar';
            message = "Fuerte";
        }
        return className
    }

    function getErrorText(editor) {
        var password = passwordButtonEdit.GetText(),
            confirmPassword = confirmPasswordButtonEdit.GetText();
        if(editor === passwordButtonEdit && isPasswordSimple(password)) {
            return "Use 8 characters or more for your password";
        } else if(editor === confirmPasswordButtonEdit && password !== confirmPassword) {
            return "The password you entered do not match";
        }
        return "";
    }

    function onPasswordValidation(s, e) {
        var errorText = getErrorText(s);
        if(errorText) {
            e.isValid = false;
            e.errorText = errorText;
        }
    }

    window.onPasswordButtonEditButtonClick = onPasswordButtonEditButtonClick;
    window.onPasswordValidation = onPasswordValidation;
    window.onPasswordTextChanged = onPasswordTextChanged;
})();