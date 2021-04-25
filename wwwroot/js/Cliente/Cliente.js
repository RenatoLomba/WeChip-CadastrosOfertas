class Cliente {
    constructor() {
        this.form = document.querySelector('#formCliente');
        this.start();
    }

    createError(field, message) {
        field.classList.add('border-danger');
        let error = document.createElement('div');
        error.classList.add('text-danger');
        error.classList.add('error-text');
        error.innerHTML = message;
        field.insertAdjacentElement('afterend', error);
    }

    validate() {
        let isValid = true;

        for (let errorText of this.form.querySelectorAll('.error-text')) {
            errorText.remove();
        }

        for (let field of this.form.querySelectorAll('.campo-cliente')) {
            if (!field.value) {
                const label = field.previousElementSibling;
                this.createError(field, `Campo ${label.innerHTML} não pode estar vazio`)
                isValid = false;
            } else {
                field.classList.remove('border-danger');
            }

            if (field.id === 'Cpf') {
                const validator = new CpfValidator();
                const cpfValid = validator.validate(field.value);
                if (!cpfValid) {
                    this.createError(field, `CPF inválido`)
                    isValid = false;
                } else {
                    field.value = field.value.replace(/\D+/g, '');
                    field.classList.remove('border-danger');
                }
            }
        }

        return isValid;
    }

    handleSubmit() {
        const isValid = this.validate();
        if (isValid) {
            this.form.submit();
        }
    }

    start() {
        this.form.addEventListener('submit', (e) => {
            e.preventDefault();
            this.handleSubmit();
        })

        this.form.querySelector('#Voltar').addEventListener('click', () => window.location.href = '../Cliente/Index')
    }
}

new Cliente();