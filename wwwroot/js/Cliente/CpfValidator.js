class CpfValidator {
    static isSequencial(cleanCpf) {
        return cleanCpf[0].repeat(cleanCpf.length) === cleanCpf;
    }

    static digitProvider(partialCpf) {
        const cpfArray = Array.from(partialCpf);
        let iterator = cpfArray.length + 1;
        const digit = 11 - (cpfArray.reduce((prev, next) => {
            const result = Number(next) * iterator;
            iterator--;
            return Number(prev) + result;
        }, 0) % 11);
        return digit > 9 ? '0' : String(digit);
    }

    validate(cpf) {
        let cleanCpf = cpf.replace(/\D+/g, '');
        if (typeof cleanCpf === 'undefined') return false;
        if (cleanCpf.length !== 11) return false;
        if (CpfValidator.isSequencial(cleanCpf)) return false;

        const partialCpf = cleanCpf.slice(0, -2);
        const firstDigit = CpfValidator.digitProvider(partialCpf);
        const secondDigit = CpfValidator.digitProvider(partialCpf + firstDigit);

        const newCpf = partialCpf + firstDigit + secondDigit;
        return newCpf === cleanCpf;
    }
}
