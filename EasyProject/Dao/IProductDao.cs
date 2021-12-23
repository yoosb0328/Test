﻿using EasyProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EasyProject.Dao
{
    public interface IProductDao
    {
        // 재고조회 - 로그인한 사용자가 소속한 부서의 재고
        List<ProductShowModel> GetProducts();

        // 재고조회 - 콤보박스 선택한 부서의 재고
        List<ProductShowModel> GetProductsByDept(DeptModel dept_dto);

        // 재고입력 - 제품 카테고리 가져오기
        List<CategoryModel> GetCategoryModels();

        // 재고입력 - 제품 입력
        void AddProduct(ProductModel prod_dto, CategoryModel category_dto);

        // 입고테이블에 추가
        void StoredProduct(ProductModel prod_dto, NurseModel nurse_dto);

        // 입고테이블 조회
        List<ProductInOutModel> GetProductIn();

        // 출고테이블 조회
        List<ProductInOutModel> GetProductOut();

        // IMP_DEPT 테이블 추가
        void AddImpDept(ProductModel prod_dto, NurseModel nurse_dto);

        // 현재 사용자의 입고 목록을 가져옴(InsertListPage)
        ObservableCollection<ProductInOutModel> GetProductInByNurse(NurseModel nurse_dto);
        // 재고 검색
        List<ProductShowModel> SearchProducts(DeptModel dept_dto, string search_type, string search_text);
        // 재고 수정
        void ChangeProductInfo(ProductShowModel prod_dto);
        void ChangeProductInfo_IMP_DEPT(ProductShowModel prod_dto);

        // 재고 출고
        void OutProduct(int? InputOutCount, ProductShowModel prod_dto, NurseModel nurse_dto, string SelectedOutType, DeptModel dept_dto);
        void ChangeProductInfo_IMP_DEPT_ForOut(int? InputOutCount, ProductShowModel prod_dto);
        void ChangeProductInfo_ForOut(int? InputOutCount, ProductShowModel prod_dto);

    }//interface

}//namespace
