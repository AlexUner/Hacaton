def get_result_formules(dict1, dict2, list_formules):
    """
    dict1 - первый словарь переменных
    dict2 - второй словарь переменных
    list_formules - список формул, записанных в виде строк. В list_formules разрешены только операции ['+', '-', '*', '/', '**'],
        наименования переменных. 
        Пример list_formules: ['( x-1 + y-2 * z-1 ) * x-1 - - 1', 'x-1 * x-1 + x-2 - z-2', 'y-1 + z-2 * x-1 + 5'].
        Операторы и операнды записаны через пробел. Если нужно показать, что операнд является переменной, то его нужно
        записать в виде 'x-1', где 'х' - наименование переменной, а '1' - принадлежность этой переменной dict1.
        Аналогично с dict2.
    
    Программа возвращает список значений, вычисленных по списку формул.
    Если в формулах присутствуют запрещенные символы, программа возвращает None.
    
    """

    dict1 = dict(dict1)
    dict2 = dict(dict2)
    
    result = []
    operations = ['+', '-', '*', '/', '**']
    
    digits = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9']
    allowed_objects = operations + digits + [' ', '(', ')', '.'] + list(set(''.join(list(dict1.keys()) + list(dict2.keys()))))
    
    for j in range(len(list_formules)):
        if set(list_formules[j]).issubset(allowed_objects):
            brakets = []
            split_formula = list_formules[j].split(' ')
            for i in range(len(split_formula)):
                if split_formula[i] not in operations and '-' in split_formula[i]:
                    split_var = split_formula[i].split('-')
                    if split_var[1] == '1' and split_var[0] in dict1.keys():
                        split_formula[i] = str(dict1[split_var[0]])
                    elif split_var[1] == '2' and split_var[0] in dict2.keys():
                        split_formula[i] = str(dict2[split_var[0]])
                    else  :
                        return 'In a formula with an index ' + str(j) + ' an unknown variable is encountered ' + str(split_formula[i])
                elif split_formula[i] in ['(', ')']:
                    if split_formula[i] == '(':
                        brakets.append('(')
                    elif split_formula[i] == ')' and len(brakets) > 0 and brakets.pop(-1) == '(':
                        continue
                    else :
                        return 'Incorrect bracket sequence In a formula with an index ' + str(j)
                elif split_formula[i] not in operations and not split_formula[i].isdigit() and '.' not in split_formula[i]:
                    return 'Incorrect formula with index ' + str(j)
            if len(brakets) > 0 :
                return 'Incorrect bracket sequence In a formula with an index ' + str(j)
            try :
                eval(''.join(split_formula))
            except :
                return 'Incorrect formula with index ' + str(j)
            result.append(eval(''.join(split_formula)))
        else :
            return 'In a formula with an index ' + str(j) + ' encountered forbidden symbols'
    
    return result
