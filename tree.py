from get_result_formules import *

def is_in_tree(tree, finding_task):
    
    """Рекурсивная функция is_in_tree принимает на вход дерево (tree) и имя задачи, которую мы хотим проверить на нахождение в дереве(finding_task).
       Обходит всё дерево и возвращает bool значение True, если задача имеется в дереве.
    """
    
    is_true = False
    
    for item in tree:
        
        if item == finding_task:
            return True
        
        is_true = is_true or is_in_tree(tree[item]['path'], finding_task)
    
    return is_true

def update_tree(tree, finding_task, input_task):
    
    """update_tree принимает на вход дерево(tree), имя задачи (finding_task), к которой мы добавляем подзадачу(input_task).
       Обновляет дерево, добавляя к 'path' ключу задачи словарь новой задачи.
    """
    
    if (finding_task == 'main'):
        
        tree['main']['path'].update(input_task)
    
    else:
        
        if (is_in_tree(tree['main']['path'], finding_task)):
            
            put_in_tree(tree['main'], finding_task, input_task)
            
        else:
            
            return None
        
    return tree

def put_in_tree(tree, finding_task, input_task):
    
    """Рекурсивная функция put_in_tree принимает на вход дерево(tree), имя задачи (finding_task), к которой мы добавляем подзадачу(input_task).
       Обходит всё дерево и обновляет по итогу словарь.
    """

    if (tree['path'] == 0): 
        return None
    
    for item in tree['path']:
        
        if item == finding_task:
            
            if finding_task in set(tree['path'][item].keys()):  
                
                return None
            
            else:
                
                tree['path'][item]['path'].update(input_task)
                    
                return None
            
        else:
            
            put_in_tree(tree['path'][item], finding_task, input_task)
            
    return None

def put_out_tree(tree, name_of_usel):
    
    """Рекурсивная функция put_out_tree принимает на вход дерево(tree) и имя узла/задачи, которую надо удалить (name_of_usel). 
       Пробегает всё дерево и удаляет по итогу нужный узел.
    """
    
    if (tree['path'] == 0):
        return None
    
    for item in tree['path']:
        
        if item == name_of_usel:
            
            tree['path'].pop(item)
            return None
        
        else:
            
            put_out_tree(tree['path'][item], name_of_usel)
            
    return None

def delete_uzel(tree, name_of_usel):
    
    """delete_uzel принимает на вход дерево(tree) и имя узла/задачи, которую надо удалить (name_of_usel). Возвращает None."""
    
    if (len(tree['main']['path']) == 0):
        return None
    
    if is_in_tree(tree['main']['path'], name_of_usel):
        
        put_out_tree(tree['main'], name_of_usel)
        
    return None

def get_parametrs(tree, name_zadacha):
    
    """Рекурсивная функция get_parametrs принимает на вход дерево (или узел дерева (tree)) и имя задачи (name_zadacha)
       и ищет в дереве задачу с подходящем именем, возвращая по итогу словарь {'x': %f, 'y': %f, ...}
    """
    
    parametrs = {}
    
    for item in tree:
        
        if item == name_zadacha:
            
            parametrs = tree[item]['zadacha_parametrs']
        
        else:
            
            parametrs = get_parametrs(tree[item]['path'], name_zadacha)
            
    return parametrs
    
def get_zadacha_parametrs(tree, name_zadacha):
    
    """get_zadacha_parametrs принимает на вход дерево (tree) и имя задачи (name_zadacha).
       Возвращает параметры задачи в формате словаря {'x': %f, 'y': %f, ...}
    """
    
    
    if (is_in_tree(tree, name_zadacha)):
        
        return get_parametrs(tree, name_zadacha)
    

def get_characteristiks(worker):
    
    """get_characteristiks принимает на вход словарь работника(worker) и возвращает оттуда словарь его характеристик формата {'x': %f, 'y': %f, ...}"""
    
    temp_dict = worker['characteristic']
    
    return temp_dict
    
# примеры словарей дерево и работник
tree = {'main': {'path': {}, 'zadacha_parametrs': {'x': 1, 'y': 2, 'z': 3}}}

worker = {'FIO': {"Ivanov", "Ivan", "Ivanovic"}, 'characteristic': {"trudobility": 1., "flexibility": .6, "skill_level": .2}}

print(*tree['main'], get_zadacha_parametrs(tree,'main')) # Вытащили параметры
print(*worker['FIO'], get_characteristiks(worker))

ans = get_result_formules(get_zadacha_parametrs(tree,'main') , get_characteristiks(worker), ['x-1 + trudobility-2']) # Применили формулу

print(['x-1 + trudobility-2'], '=', ans)